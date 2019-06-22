testcases = gets.to_i
(1..testcases).each do |tc|
  s = gets.chomp
  b = s.count("B");
  d = s.count(".");
  ans = "N"
  if (b == 0 && d == 0) then ans = "Y" end
  if (d > 0) then
    if(b > 1) then ans = "Y" end
    if(d <= b) then ans = "Y" end
  end  
  puts "Case ##{tc}: "+ans
end