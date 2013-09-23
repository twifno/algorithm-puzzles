m1 = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]
m2 = ["", "", "double", "triple",
          "quadruple",
            "quintuple",
              "sextuple",
                "septuple",
                  "octuple",
                    "nonuple",
                      "decuple"]
lines = ARGF.read.split "\n"
T = lines[0].to_i
(1..T).each do |t|
  s = "Case ##{t}: ";
  line = lines[t]
  n = (line.split)[0]
  fs = (line.split)[1].split("-")
  count = 0;
  fs.each do |f|
    f = f.to_i
    c = 0
    (count...(count+f)).each do |i|
      if c==0
        c = 1
      elsif n[i] == n[i-1]
        c += 1
      elsif c > 10
        ((i-c)...i).each do |j|
          s += m1[n[j].to_i]
          if j != n.size
            s += " "
          end
        end
        c = 1
      else
        s +=m2[c]
        if c > 1
          s +=" "
        end
        s +=m1[n[i-1].to_i]
        if i != n.size
          s += " "
        end
        c = 1
      end
    end
    count += f
    if c > 10
      ((count-c)...count).each do |j|
        s += m1[n[j].to_i]
        if j != n.size
          s += " "
        end
      end
    elsif c > 0
      s +=m2[c]
      if c > 1
        s +=" "
      end
      s +=m1[n[count-1].to_i]
      if count != n.size
        s += " "
      end
    end


  end
  puts s
end
