def decrypt(ss)
  pre = nil
  cs = []
  ss.each do |s|
  	i = s.to_i
  	if(pre == nil)
  		pre = i
  	else
  		gcd = pre.gcd(i)
      pre = i
  		cs << gcd
  	end
  end
  cs.unshift(ss[0].to_i / cs[0])
  cs << (ss.last.to_i / cs.last)
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

def mul(ss)
  return ss[0].to_i * ss[1].to_i
end

cn = gets.to_i
(1..cn).each do |i|
  ss = gets.split
  res = mul(ss)
  res = res.gcd(ss[0].to_i)
  puts "Case ##{i}: "+res.to_s
end
