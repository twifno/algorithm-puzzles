res = {}
res["all"] = {}
res["male"] = {}
ARGF.each do |line|
    #puts line
    lele = line.split(',');
    res["all"][lele[0]] = 1
    if lele[2] == 'M' then res["male"][lele[0]] = 1 end
end

res.each do |k, v|
  puts k
  count = 0
  v.each do
    count += 1
  end
  puts count
end
