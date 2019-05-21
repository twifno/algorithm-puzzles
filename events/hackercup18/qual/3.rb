testcases = gets.to_i
(1..testcases).each do |tc|
  s = gets.chomp
  ret = "Impossible"
  (1...s.length).each do |i|
    if s[0] == s[i]
      sub = s[i..-1];
      if !s.start_with?(sub)
        ret = s[0...i] + s
        break
      end
    end
  end
  puts "Case ##{tc}: "+ret
end
