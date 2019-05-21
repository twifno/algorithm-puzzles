def mod(a, b)
  gcd = a.gcd(b)
  a = a/gcd
  b = b/gcd
  p = 1000000007
  c = 1000000005
  a = a % p
  ans = b % p
  while c != 0
    if c & 1 == 1
      ans = ans * a % p
    end
    c >>= 1
    a = a*a % p
  end
  return ans
end

testcases = gets.to_i
(1..testcases).each do |tc|
  nm = gets.chomp.split(" ")
  n = nm[0].to_i
  m = nm[1].to_i

  fenceA = Array.new(n)
  fenceB = Array.new(n)
  (1...n).each do |i|
    ab = gets.chomp.split(" ")
    fenceA[i] = ab[0].to_i
    fenceB[i] = ab[1].to_i
  end

  y = Array.new(m)
  h = Array.new(m)
  (0...m).each do |i|
    yh = gets.chomp.split(" ")
    y[i] = yh[0].to_i
    h[i] = yh[1].to_i
  end

  p = 1000000007

  pob = Array.new(n+1, 1)
  (0...m).each do |i|
    curY = y[i]
    curH = h[i]
    pob[curY] = 0
    tmpY = curY
    tmpP = 1
    while(tmpY > 1)
      a = fenceA[tmpY-1]
      b = fenceB[tmpY-1]
      if b <= curH
        pob[tmpY-1] = 0
      elsif a > curH
        break
      else
        tmpP = tmpP * mod(b-a+1, curH-a+1) % p
        pob[tmpY-1] = pob[tmpY-1] * (1+p-tmpP) % p
      end
      tmpY -= 1
    end
    tmpY = curY
    tmpP = 1
    while(tmpY < n)
      a = fenceA[tmpY]
      b = fenceB[tmpY]
      if b <= curH
        pob[tmpY+1] = 0
      elsif a > curH
        break
      else
        tmpP = tmpP * mod(b-a+1, curH-a+1) % p
        pob[tmpY+1] = pob[tmpY+1] * (1+p-tmpP) % p
      end
      tmpY += 1
    end
  end
  nosave = 1
  (1..n).each do |i|
    nosave = nosave * (1+p-pob[i]) % p
  end
  puts "Case ##{tc}: #{(1+p-nosave) % p}"
end
