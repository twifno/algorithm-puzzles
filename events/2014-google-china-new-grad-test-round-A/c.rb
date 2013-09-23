lines = ARGF.read.split "\n"
T = lines[0].to_i
(1..T).each do |t|
  s = "Case ##{t}: ";
  n = lines[2*t-1]
  ns = lines[2*t].split.map {|i| i.to_i}
  odd = []
  even = []
  mark = []
  ns.each_index do |i|
    if ns[i] % 2 == 0
      even << ns[i]
      mark << 0
    else
      odd << ns[i]
      mark << 1
    end
  end
  even.sort!
  odd.sort! {|x, y| y<=>x}
  res = []
  mark.each_index do |i|
    if mark[i] == 0
      res << even.pop
    else
      res << odd.pop
    end
  end
  res.each_index do |i|
    s += res[i].to_s
    if i != res.size-1
      s+=" "
    end
  end
  puts s
end
