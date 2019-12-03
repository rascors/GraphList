//Найти все пути между двумя вершинами не пересекающий кратчайший путь между двумя другими вершинами (стек_спис, граф_спис)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Path = Graph.StackList<Graph.GraphNode>;

namespace Graph
{
	public class GraphNode
	{
		public string name;
		public bool Visited;
		public List<GraphNode> connectedVertex;
		public int index;
	}

	public class Adge
	{
		
	}

	public abstract class AbtractGraph
	{
		
		//- конструктор;
		//- метод для построения всех путей или циклов, удовлетворяющих некоторому
		//условию;
		//- абстрактный метод для поиска ещё не обработанной смежной вершины;
		//- абстрактный метод для проверки соответствия построенного пути или цикла
		//заданным условиям.


		public abstract void AddVertex();

		public abstract void InsertEdge(GraphNode connectedVertex, int weight);

		public abstract GraphNode NextConnectedVertex(GraphNode vertex);

		public abstract void VisitVertex(GraphNode vertex);

		public abstract void UnvisitVertex(GraphNode vertex);

		virtual public List<GraphNode> DepthFrirstSearch(GraphNode first) 
		{
			if (first == null)
			{
				throw new Exception();
			}
			List<Path> result = new List<Path>();
			Path path = new Path();
			path.Push(first);
			VisitVertex(first);
			while(!path.IsEmpty())
			{
				
			}


			return default;
		}
	}

	public class PrintGraph : AbtractGraph
	{
		private List<GraphNode> paths = new List<GraphNode>();
		private List<GraphNode> adjacencyList = new List<GraphNode>();

		internal List<GraphNode> AdjacencyList { get => adjacencyList; set => adjacencyList = value; }

		public override void AddVertex()
		{
			throw new NotImplementedException();
		}

		public override GraphNode NextConnectedVertex(GraphNode vetex)
		{
			if(vetex.connectedVertex.MoveNext() != true)
			{
				vetex.connectedVertex.Reset();
				return null;
			}
			if(vetex.connectedVertex.Current.Visited)
			{
				return NextConnectedVertex(vetex);
			}
			return vetex.connectedVertex.Current;
		}

		public override void InsertEdge(GraphNode connectedVetex, int weight)
		{
			throw new NotImplementedException();
		}

		public override void VisitVertex(GraphNode vertex)
		{
			throw new NotImplementedException();
		}

		public override void UnvisitVertex(GraphNode vertex)
		{
			throw new NotImplementedException();
		}
	}
}
