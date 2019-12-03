using System.Collections;
using System.Collections.Generic;

namespace Graph
{
	public class NodeList<T>
	{
		public T data;
		public NodeList<T> next;
		public NodeList<T> prev;

		public NodeList(T newData)
		{
			data = newData;
			next = null;
			prev = null;
		}
	}

	public class List<T> : IEnumerator<T>
	{
		private NodeList<T> head;
		private NodeList<T> tail;
		private int size;
		

		public List()
		{
			head = null;
			tail = null;
			size = 0;
		}

		public bool Find(T data)
		{
			NodeList<T> temp = head;
			while (temp != null)
			{
				if (temp.data.Equals(data))
				{
					return true;
				}
				temp = temp.next;
			}
			return false;
		}

		public void PushBack(T data)
		{
			NodeList<T> newNode = new NodeList<T>(data);
			PushBack(newNode);
		}

		private void PushBack(NodeList<T> node)
		{
			if (head == null)
			{
				head = node;
			}
			else
			{
				tail.next = node;
				node.prev = tail;
			}
			tail = node;
			size++;
		}


		public void Remove(T data)
		{
			NodeList<T> temp = head;
			while (temp != null)
			{
				if (temp.data.Equals(data)) break;
				temp = temp.next;
			}

			if (temp != null)
			{
				if (temp.next != null)
				{
					temp.next.prev = temp.prev;
				}
				else
				{
					tail = temp.prev;
				}
				if (temp.prev != null)
				{
					temp.prev.next = temp.next;
				}
				else
				{
					head = temp.next;
				}
				size--;
			}
		}

		private NodeList<T> curr, next;

		public T Current => curr.data;

		object IEnumerator.Current => curr.data;

		public void Dispose() {}

		public bool MoveNext()
		{
			curr = next;
			next = next?.next;
			return curr != null;
		}

		public void Reset()
		{
			next = head;
		}

		public IEnumerator<T> GetEnumerator()
		{
			this.Reset();
			return this;
		}
	}
}
