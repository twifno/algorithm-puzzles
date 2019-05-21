def decrypt(ss)
  pre = ss[0].to_i
  ss.each do |s|
    i = s.to_i
    if pre != i
      pre = pre.gcd(i)
      break
    end
  end
  pre = ss[0].to_i / pre
  cs = []
  cs << pre
  ss.each do |s|
  	pre = s.to_i / pre
    cs << pre
  end
  uniq = cs.uniq.sort!
  aph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
  map = {}
  idx = 0
  uniq.each do |u|
    map[u] = aph[idx]
    idx += 1
  end
  cs = cs.map{|c| map[c]}
  return cs.join("")
end

cn = gets.to_i
(1..cn).each do |i|
  gets
  ss = gets.split
  res = decrypt(ss)
  puts "Case ##{i}: "+res
end
