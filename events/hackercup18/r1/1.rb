testcases = gets.to_i
(1..testcases).each do |tc|
  n = gets.chomp.to_i
  grid = {}
  grid[0] = gets.chomp
  grid[1] = gets.chomp
  grid[2] = gets.chomp
  right = Array.new(3) { Array.new(n, 0) }
  top = Array.new(3) { Array.new(n, 0) }
  bottom  = Array.new(3) { Array.new(n, 0) }

  if(grid[0][0] == "#")
    puts "Case ##{tc}: 0"
    next
  end

  bottom[0][0] = 1
  (0...n).each do |i|
    (0...3).each do |j|
      if (grid[j][i] == "#")
        next
      end
      if (j > 0)
        right[j][i] += bottom[j-1][i] % 1000000007
      end
      if (i > 0)
        top[j][i] += right[j][i-1] % 1000000007
        bottom[j][i] += right[j][i-1] % 1000000007
      end
    end
    1.downto(0) do |j|
      if (grid[j][i] == "#")
        next
      end
      right[j][i] += top[j+1][i] % 1000000007
    end
  end

  puts "Case ##{tc}: #{right[2][n-1]}"
end
