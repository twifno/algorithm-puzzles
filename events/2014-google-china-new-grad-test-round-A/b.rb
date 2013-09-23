def getr(n)
  if n == 1
    return [1, 1]
  end
  r = n % 2
  q = n / 2
  res = getr(q)
  if r == 0
    res[1] = res[0]+res[1]
  else
    res[0] = res[0] + res[1]
  end
  return res
end

def getindex(i, j)
  if i==1 && j == 1
    return [1, 1]
  end
  if i > j 
    res = getindex(i-j, j)
    if res[0] == 0
      res[0] = 1
    else
      res[0] = res[0]*2
    end
    res[1] = res[1]*2
  else
    res = getindex(i, j-i)
    if res[0] == 0
      res[0] = 1
    else
      res[0] = res[0]*2
    end
    res[1] = res[1]*2-1
  end
  return res
end


lines = ARGF.read.split "\n"
T = lines[0].to_i
(1..T).each do |t|
  s = "Case ##{t}: ";
  line = lines[t]
  ns = line.split.map {|i| i.to_i}
  #puts "ns #{ns[0]}"
  if ns[0] == 1
    res = getr(ns[1])
    s += res[0].to_s
    s += " "
    s += res[1].to_s
  else
    res = getindex(ns[1], ns[2])
    s += (res[0]+res[1]-1).to_s
  end
  puts s
end


