using System.Collections.Generic;

namespace ProgrammingChallenges.ManningAlgorithms;

/*
Este algoritmo tem 4 etapas e auxilia a encontrar o caminho mais rápido:
1- encontre o vértice mais "barato". este é o vértice que você consegue chegar no menor tempo possível
2- atualize o custo dos vizinhos desse vértice
3- repita até que você tenha feito isso para cada vértice do grafo
4- calcule o caminho final

Cada número associado a aresta do grafo é chamado de 'peso'
Um grafo com pesos é chamado de grafo ponderado
*/
public static class Dijkstra
{
    private class Weight
    {
        public Node From { get; }
        public int Value { get; }

        public Weight(Node @from, int value)
        {
            From = @from;
            Value = value;
        }
    }

    class VisitingData
    {
        readonly List<Node> _visiteds = [];

        readonly Dictionary<Node, Weight> _weights =
            new Dictionary<Node, Weight>();

        readonly List<Node> _scheduled = [];

        public void RegisterVisitTo(Node node)
        {
            if (!_visiteds.Contains(node))
                _visiteds.Add((node));
        }

        public bool WasVisited(Node node)
        {
            return _visiteds.Contains(node);
        }

        public void UpdateWeight(Node node, Weight newWeight)
        {
            if (!_weights.ContainsKey(node))
            {
                _weights.Add(node, newWeight);
            }
            else
            {
                _weights[node] = newWeight;
            }
        }

        public Weight QueryWeight(Node node)
        {
            Weight result;
            if (!_weights.ContainsKey(node))
            {
                result = new Weight(null, int.MaxValue);
                _weights.Add(node, result);
            }
            else
            {
                result = _weights[node];
            }
            return result;
        }

        public void ScheduleVisitTo(Node node)
        {
            _scheduled.Add(node);
        }

        public bool HasScheduledVisits => _scheduled.Count > 0;

        public Node GetNodeToVisit()
        {
            var ordered = from n in _scheduled
                            orderby QueryWeight(n).Value
                            select n;

            var result = ordered.First();
            _scheduled.Remove(result);
            return result;
        }

        public bool HasComputedPathToOrigin(Node node)
        {
            return QueryWeight(node).From != null;
        }

        public IEnumerable<Node> ComputedPathToOrigin(Node node)
        {
            var n = node;
            while (n != null)
            {
                yield return n;
                n = QueryWeight(n).From;
            }
        }
    }

    public static Node[]? FindShortestPath(Node @from, Node to)
    {
        var control = new VisitingData();

        control.UpdateWeight(@from, new Weight(null, 0));
        control.ScheduleVisitTo(@from);

        while (control.HasScheduledVisits)
        {
            var visitingNode = control.GetNodeToVisit();
            var visitingNodeWeight = control.QueryWeight(visitingNode);
            control.RegisterVisitTo(visitingNode);

            foreach (var neighborhoodInfo in visitingNode.Neighbors)
            {
                if (!control.WasVisited(neighborhoodInfo.Node))
                {
                    control.ScheduleVisitTo(neighborhoodInfo.Node);
                }

                var neighborWeight = control.QueryWeight(neighborhoodInfo.Node);

                var probableWeight = (visitingNodeWeight.Value + neighborhoodInfo.WeightToNode);
                if (neighborWeight.Value > probableWeight)
                {
                    control.UpdateWeight(neighborhoodInfo.Node, new Weight(visitingNode, probableWeight));
                }
            }
        }

        return control.HasComputedPathToOrigin(to)
            ? control.ComputedPathToOrigin(to).Reverse().ToArray()
            : null;
    }
}

public class Node
{
    public string Label { get; }
    public Node(string label)
    {
        Label = label;
    }

    readonly List<Edge> _edges = [];
    public IEnumerable<Edge> Edges => _edges;

    public IEnumerable<NeighborhoodInfo> Neighbors =>
        from edge in Edges
        select new NeighborhoodInfo(
            edge.Node1 == this ? edge.Node2 : edge.Node1,
            edge.Value
            );

    private void Assign(Edge edge)
    {
        _edges.Add(edge);
    }

    public void ConnectTo(Node other, int connectionValue)
    {
        Edge.Create(connectionValue, this, other);
    }

    public struct NeighborhoodInfo
    {
        public Node Node { get; }
        public int WeightToNode { get; }

        public NeighborhoodInfo(Node node, int weightToNode)
        {
            Node = node;
            WeightToNode = weightToNode;
        }
    }

    public class Edge
    {
        public int Value { get; }
        public Node Node1 { get; }
        public Node Node2 { get; }

        public Edge(int value, Node node1, Node node2)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Edge value needs to be positive.");
            }
            Value = value;
            Node1 = node1;
            node1.Assign(this);
            Node2 = node2;
            node2.Assign(this);
        }

        public static Edge Create(int value, Node node1, Node node2)
        {
            return new Edge(value, node1, node2);
        }
    }
}