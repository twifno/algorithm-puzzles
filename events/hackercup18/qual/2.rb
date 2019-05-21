testcases = gets.to_i
(1..testcases).each do |tc|
  num = gets.chomp.to_i
  (0..num).each do
    dump = gets
  end
  if num % 2 == 1
    puts "Case ##{tc}: 1"
    puts "0.0"
  else
    puts "Case ##{tc}: 0"
  end
end
