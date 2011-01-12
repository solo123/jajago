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

def gen_mobile(mobile)
  s = "INSERT INTO Mobiles (id, title, standard, description, price_shop, price_market) VALUES (#{mobile.goods_id}, '#{mobile.goods_name}', 'standard', '#{sql_escape(mobile.goods_desc)}', '#{mobile.shop_price}', '#{mobile.shopout_price}')\ngo\n" 
end
def sql_escape(str)
  str.gsub(/['\n\r]/, "'" => "''", "\n" => '\n', "\r" => '')
end

File.open('out.txt', 'w') do|f| 
  EcsGood.where('goods_id<10').order('goods_id').each do |m|
    f.puts gen_mobile(m)
    
  end
end
