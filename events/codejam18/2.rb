cn = gets.to_i
(1..cn).each do |i|
  num = gets.to_i
  arr = gets.split(" ").map {|c| c.to_i}
  ar0 = []
  ar1 = []
  (0...arr.length).each do |i|
    if i.even?
      ar0.push(arr[i])
    else
      ar1.push(arr[i])
    end
  end
  ar0.sort!
  ar1.sort!
  find0 = false;
  pos0 = 0;
  find1 = false;
  pos1 = 0;
  (1...ar0.length).each do |i|
    if(ar0[i] < ar1[i-1])
      find0 = true;
      pos0 = i*2-1;
      break
    end
  end
  (0...ar1.length).each do |i|
    if(ar1[i] < ar0[i])
      find1 = true;
      pos1 = i*2;
      break
    end
  end
  pos = 999999
  if find0
    pos = pos0
  end
  if find1 and pos1 < pos
    pos = pos1
  end
  if not find0 and not find1
    puts "Case ##{i}: OK"
  else
    puts "Case ##{i}: #{pos}"
  end
  puts ar0
  puts ar1
end
