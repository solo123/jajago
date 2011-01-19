require 'rubygems'
require 'active_record'

class JajagoDB < ActiveRecord::Base
  self.abstract_class = true
  establish_connection(
   :adapter  => "mysql2",
   :database => "jajago",
   :encoding => "utf8",
   :username => "root",
   :host     => 'localhost'
  )
end
class EcsGood < JajagoDB
  set_primary_key "goods_id"
end 
class EcsAttribute < JajagoDB
  set_table_name "ecs_attribute"
  set_primary_key "attr_id"
end
class EcsGoodsAttr < JajagoDB
  set_table_name "ecs_goods_attr"
  set_primary_key "goods_attr_id"
end

def gen_mobile(mobile)
  imgurl = mobile.original_img
  if !imgurl || imgurl.empty?
	imgurl = mobile.goods_img
  end
  "INSERT INTO Mobiles (id, title, description, price_shop, price_market, img_url, status) VALUES (#{mobile.goods_id}, '#{mobile.goods_name}', '#{sql_escape(mobile.goods_desc)}', '#{mobile.shop_price}', '#{mobile.shopout_price}', '#{imgurl}', 0)\ngo\n" 
end
def gen_attribute(attribute)
  "INSERT INTO MobileAttributes (id,title) VALUES (#{attribute.attr_id}, '#{sql_escape attribute.attr_name}')\ngo\n"
end
def gen_mobile_attr(attr)
  "INSERT INTO MobileInAttributes (id,mobile_id,attribute_id,title) VALUES (#{attr.id}, #{attr.goods_id}, #{attr.attr_id}, '#{sql_escape attr.attr_value}')\ngo\n"
end
def sql_escape(str)
  str.gsub(/['\n\r]/, "'" => "''", "\n" => '\n', "\r" => '')
end

File.open('out.txt', 'w') do|f| 
  f.puts "delete from mobiles\ngo\ndelete from mobileattributes\ngo\ndelete from mobileinattributes\ngo\n\n";
  # attributes
  EcsAttribute.all.each { |attr| f.puts gen_attribute(attr) }
  EcsGood.where('goods_id<200').order('goods_id').each do |m| 
	f.puts gen_mobile(m)
	EcsGoodsAttr.where('goods_id=?', m.id).order('attr_id').each { |attr| f.puts gen_mobile_attr(attr) }
  end
end
