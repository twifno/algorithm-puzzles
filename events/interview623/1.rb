res = {}
ARGF.each do |line|
    #puts line
    lele = line.split(',');
    if lele[5] != 'subscriber' && lele[5] != 'spouse' && lele[5] != 'child' && lele[5] != 'domestic_partner' && lele[5] != 'spou' then puts lele[5] end
    if lele[1] == 'Donald Duck Co.' && (lele[5] == 'subscriber'||lele[5] == 'subscr') && lele[6] == 'Medical' && lele[7].include?('PPO') then
      if !res.key?(lele[3]) then res[lele[3]] = {} end
      res[lele[3]][lele[0]] = 1
    end
end

res.each do |k, v|
  puts k
  count = 0
  v.each do
    count += 1
  end
  puts count
end
