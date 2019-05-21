testcases = gets.to_i
(1..testcases).each do |tc|
  ss = gets.chomp.split(" ")
  n = ss[0].to_i
  k = ss[1].to_i
  v = ss[2].to_i
  att = []
  (1..n).each do
    att << gets.chomp
  end
  sp = (v*k-k)
  visits = []
  nums = []
  (1..k).each do
    nums << sp % n
    sp += 1
  end
  nums.sort! {|a, b| a <=> b}
  nums.each do |num|
    visits << att[num]
  end
  puts "Case ##{tc}: "+visits.join(" ")
end
