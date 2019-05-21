class Node
  attr_accessor :pre_order
  attr_accessor :post_order
  attr_accessor :num
  attr_accessor :left
  attr_accessor :right
end



def preorder(ns, pos, pre)
  return unless pos != 0
  #puts "ns #{pos} left #{ns[pos].left} right #{ns[pos].right}"
  cur = pre.size
  pre << ns[pos]
  node = ns[pos]
  node.pre_order = cur
  preorder(ns, ns[pos].left, pre)
  preorder(ns, ns[pos].right, pre)
end

def postorder(ns, pos, post)
  return unless pos != 0
  postorder(ns, ns[pos].left, post)
  postorder(ns, ns[pos].right, post)
  #puts "ns #{pos} left #{ns[pos].left} right #{ns[pos].right}"
  cur = post.size
  post << ns[pos]
  node = ns[pos]
  node.post_order = cur
end

testcases = gets.to_i
(1..testcases).each do |tc|
  nk = gets.chomp.split(" ")
  n = nk[0].to_i
  k = nk[1].to_i

  ns = Array.new(n+1)
  (1..n).each do |i|
    ns[i] = Node.new
    lr = gets.chomp.split(" ")
    ns[i].left = lr[0].to_i
    ns[i].right = lr[1].to_i
    ns[i].num = 0
  end

  pre = []
  preorder(ns, 1, pre)
  post = []
  postorder(ns, 1, post)

  cur = 1
  done = false
  (0...pre.size).each do |i|
    nxt = pre[i]
    if nxt.num != 0
      next
    end
    while nxt.num == 0
      #puts "post order #{nxt.post_order}"
      nxt.num = cur
      nxt = pre[nxt.post_order]
    end
    if cur < k
      cur += 1
    else
      done = true
    end
  end

  if !done then
    puts "Case ##{tc}: Impossible"
  else

    labels = []
    (1..n).each do |i|
      labels << ns[i].num
    end
    puts "Case ##{tc}: #{labels.join(" ")}"
  end
end
