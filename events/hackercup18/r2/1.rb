class Node
  attr_accessor :children
  attr_accessor :wants
end

$max = 0

def find(root, candies)
  remains = []
  candies[root].children.each do |i|
    f = find(i, candies)
    if f != nil
      remains.concat(f)
    end
  end
  remains << root
  remains.sort! { |x,y| y <=> x }
  cut = candies[root].wants
  cuts = remains[0...cut]
  $max += cuts.inject(0, :+)
  return remains[cut..-1]
end

testcases = gets.to_i
(1..testcases).each do |tc|
  input = gets.chomp.split(" ")
  n = input[0].to_i
  m = input[1].to_i
  a = input[2].to_i
  b = input[3].to_i
  ps = []
  (1...n).each do
    ps << gets.chomp.to_i
  end

  candies = {}

  (0..n).each do |i|
    candies[i] = Node.new
    candies[i].children = []
    candies[i].wants = 0
  end
  (1...n).each do |i|
    candies[ps[i-1]].children << i
  end

  (0...m).each do |i|
    c = (a * i + b) % n
    candies[c].wants += 1
  end

  $max = 0
  find(0, candies)

  puts "Case ##{tc}: #{$max}"
end
