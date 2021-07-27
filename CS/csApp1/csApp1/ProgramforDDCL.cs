using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csApp1  //dummy headed doubly circular linked list
{

	class Node
	{

		private int value;
		public Node next;
		public Node prev;

		public Node(int v, Node n, Node p)
		{
			this.value = v;
			this.next = n;
			this.prev = p;
		}

		public int Value
		{
			get { return value; }
			// set { this.value = value;  }
		}


	}

	class DubLinCir
	{
		public static Node head;

		public DubLinCir(int[] arr)
		{
			head = new Node(0, null, null);
			Node tail = head;

			for (int i = 0; i < arr.Length; i++)
			{
				Node n = new Node(arr[i], null, null);
				tail.next = n;
				n.prev = tail;
				tail = tail.next;

			}

			tail.next = head;
			head.prev = tail;

		}


		public void insert(int idx, int elem)
		{
			int count = 0;
			Node m = new Node(elem, null, null);
			for (Node n = head.next; n != head; n = n.next)
			{
				if (idx < 0)
				{
					Console.WriteLine("Wrong index (" + idx + ") input!");
					break;
				}
				else if (count == idx)
				{
					m.next = n;
					m.prev = n.prev;

					n.prev.next = m;
					n.prev = m;

				}

				count++;
			}

			if (count < idx)
			{
				Console.WriteLine("Wrong index (" + idx + ") input!");
			}

		}


		public void remove(int delkey)
		{
			bool flag = true;
			for (Node n = head.next; n != head; n = n.next)
			{
				if (n.Value == delkey)
				{
					n.prev.next = n.next;
					n.next.prev = n.prev;
					flag = false;
					break;
				}
			}

			if (flag)
			{
				Console.WriteLine("This element (" + delkey + ") doesn't exist!");
			}
		}


		public void printF()
		{
			for (Node n = head.next; n != head; n = n.next)
			{
				Console.Write(n.Value + " ");
			}
		}


		public void printB()
		{
			for (Node n = head.prev; n != head; n = n.prev)
			{
				Console.Write(n.Value + " ");
			}


		}


	}

	class ProgramforDDCL
	{
		static void Main(string[] args)
		{
			 
			int[] a = { 10, 20, 30, 40, 50 };
			DubLinCir d = new DubLinCir(a);

			Console.Write("Inserting: ");
			d.insert(-1, 100); d.printF();
			Console.WriteLine();
			Console.Write("Removing: ");
			d.remove(1); d.printF();
			Console.WriteLine();

			Console.Write("Printing forward: ");
			d.printF();
			Console.WriteLine();
			Console.Write("Printing backward: ");
			d.printB();


			Console.ReadLine();

			
		}
	}
}




