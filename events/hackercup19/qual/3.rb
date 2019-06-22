def getResult(s)
  if(s[0] != "(") then return s end
  if(s[1] != "(") 
    r1 = s[1];
    op = s[2];
    r2 = getResult(s[3..-2])
  else
    n = nextV(s, 1)
    r1 = getResult(s[1..n])
    op = s[n+1]
    r2 = getResult(s[n+2..-2])
  end
  #puts r1
  #puts op
  #puts r2
  return cal(r1, op, r2)
end

def nextV(s,idx)
  count = 0;
  (idx..s.length).each do |i|
    if s[i] == "(" then count += 1
    elsif s[i] == ")" then count -= 1 end
    if count==0 then return i end
  end
end

def neg(x)
  if x == "x" 
    return "X"
  else
    return "x"
  end
end

def cal(r1, op, r2)
  if op=="&"
    if r1 == "0" || r2 == "0"
      return "0"
    end
    if r1 == "1"
      return r2
    end
    if r2 == "1"
      return r1
    end
    if r1 == r2
      return r1
    end
    return "0"
  elsif op=="|"
    if r1 == "1" || r2 == "1"
      return "1"
    end
    if r1 == "0"
      return r2
    end
    if r2 == "0"
      return r1
    end
    if r1 == r2
      return r1
    end
    return "1"
  else
    if r1 == r2
      return "0"
    end
    if r1 == "0" && r2 != "1"
      return r2
    end
    if r2 == "0" && r1 != "1"
      return r1
    end
    if r1 == "1" && r2 != "0"
      return neg(r2)
    end
    if r2 == "1" && r1 != "0"
      return neg(r1)
    end
    return "1"
  end
end

testcases = gets.to_i
(1..testcases).each do |tc|
  s = gets.chomp
  res = getResult(s)
  ret = (res == "1" || res == "0")?"0":"1"
  puts "Case ##{tc}: "+ret
end

