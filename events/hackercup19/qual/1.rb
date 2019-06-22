testcases = gets.to_i
(1..testcases).each do |tc|
  s = gets.chomp
  b = s.count("B");
  d = s.count(".");
  puts "Case ##{tc}: "+(((d==0 && b==0) || (d>0 && d<=b))?"Y":"N")
end
