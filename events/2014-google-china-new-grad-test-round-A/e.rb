class Edge
  attr_accessor :src, :dst, :length
  
  def initialize(src, dst, length = 1)
    @src = src
    @dst = dst
    @length = length
  end
end
 
class Graph < Array
  attr_reader :edges
  
  def initialize
    @edges = []
  end
  
  def connect(src, dst, length = 1)
    unless self.include?(src)
      raise ArgumentException, "No such vertex: #{src}"
    end
    unless self.include?(dst)
      raise ArgumentException, "No such vertex: #{dst}"
    end
    @edges.push Edge.new(src, dst, length)
  end
  
  def connect_unmutually(vertex1, vertex2, length = 1)
    self.connect vertex1, vertex2, length
  end
  def connect_mutually(vertex1, vertex2, length = 1)
    self.connect vertex1, vertex2, length
    self.connect vertex2, vertex1, length
  end
 
  def neighbors(vertex)
    neighbors = []
    @edges.each do |edge|
      neighbors.push edge.dst if edge.src == vertex
    end
    return neighbors.uniq
  end
 
  def length_between(src, dst)
    @edges.each do |edge|
      return edge.length if edge.src == src and edge.dst == dst
    end
    nil
  end
 
  def dijkstra(src, dst = nil)
    distances = {}
    previouses = {}
    self.each do |vertex|
      distances[vertex] = nil # Infinity
      previouses[vertex] = nil
    end
    distances[src] = 0
    vertices = self.clone
    until vertices.empty?
      nearest_vertex = vertices.inject do |a, b|
        next b unless distances[a]
        next a unless distances[b]
        next a if distances[a] < distances[b]
        b
      end
      break unless distances[nearest_vertex] # Infinity
      if dst and nearest_vertex == dst
        return distances[dst]
      end
      neighbors = vertices.neighbors(nearest_vertex)
      neighbors.each do |vertex|
        alt = distances[nearest_vertex] + vertices.length_between(nearest_vertex, vertex)
        if distances[vertex].nil? or alt < distances[vertex]
          distances[vertex] = alt
          previouses[vertex] = nearest_vertex
          # decrease-key v in Q # ???
        end
      end
      vertices.delete nearest_vertex
    end
    if dst
      return nil
    else
      return distances
    end
  end
end
 
lines = ARGF.read.split "\n"
T = lines[0].to_i
lm = 1;
(1..T).each do |t|
  s = "Case ##{t}:";
  nn = lines[lm].to_i
  lm +=1
  graph = Graph.new
  c = {}
  (1..nn).each {|n| graph.push n}
  (1..nn).each do |i|
    color = lines[lm]
    lm += 1
    c[i] = color
  end
  mm = lines[lm].to_i
  lm += 1
  (1..mm).each do |i|
    line = lines[lm]
    lm+=1
    ns = line.split.map {|i| i.to_i}
    graph.connect_unmutually ns[0], ns[1], ns[2]
  end
  ss = lines[lm].to_i
  lm += 1
  puts s
  (1..ss).each do |i|
    line = lines[lm]
    lm+=1
    ns = line.split.map {|i| i.to_i}
    res = nil
    c.each do |k, co|
      if res == nil && co == c[ns[1]]
        res = graph.dijkstra(ns[0], k)
      end
    end
    if res == nil
      puts "-1"
    else
      puts res
    end
  end
end
