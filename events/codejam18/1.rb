def g(s)
  b = 1
  t = 0
  s.each_char do |c|
    if c=="C"
      b *= 2
    else
      t += b
    end
  end
  return t
end

def move(s)
  meet = false
  (0...s.length).reverse_each do |i|
    if s[i]=="S" then meet = true end
    if meet and s[i]=="C"
      s[i] = "S"
      s[i+1] = "C"
      return s
    end
  end
end

cn = gets.to_i
(1..cn).each do |i|
  ss = gets.split
  d = ss[0].to_i
  if ss[1].count("S") > d
    puts "Case ##{i}: IMPOSSIBLE"
    next
  end
  s = ss[1];
  count = 0
  while g(s) > d
    count += 1
    s = move(s)
  end
  puts "Case ##{i}: "+count.to_s
end
