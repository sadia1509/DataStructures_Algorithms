/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ProgramforDDCL;

/**
 *
 * @author Sadia Afrose
 */

    /**
     * @param args the command line arguments
     */
   class Node
	{

		public int value;
		public Node next;
		public Node prev;

		public Node(int v, Node n, Node p)
		{
			this.value = v;
			this.next = n;
			this.prev = p;
		}


	}
        

	class DubLinCir
	{
		public Node head;

		public DubLinCir(int[] arr)
		{
			head = new Node(0, null, null);
			Node tail = head;

			for (int i = 0; i < arr.length; i++)
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
					System.out.println("Wrong index (" + idx + ") input!");
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
				System.out.println("Wrong index (" + idx + ") input!");
			}

		}


		public void remove(int delkey)
		{
			boolean flag = true;
			for (Node n = head.next; n != head; n = n.next)
			{
				if (n.value == delkey)
				{
					n.prev.next = n.next;
					n.next.prev = n.prev;
					flag = false;
					break;
				}
			}

			if (flag)
			{
				System.out.println("This element (" + delkey + ") doesn't exist!");
			}
		}


		public void printF()
		{
			for (Node n = head.next; n != head; n = n.next)
			{
				System.out.print(n.value + " ");
			}
		}


		public void printB()
		{
			for (Node n = head.prev; n != head; n = n.prev)
			{
				System.out.print(n.value + " ");
			}


		}


	}

	public class ProgramforDDCL
	{
		public static void main(String [] args) 
		{
			 
			int[] a = { 10, 20, 30, 40, 50 };
			DubLinCir d = new DubLinCir(a);

			System.out.print("Inserting: ");
			d.insert(-1, 100); d.printF();
			System.out.println();
			System.out.print("Removing: ");
			d.remove(1); d.printF();
			System.out.println();

			System.out.print("Printing forward: ");
			d.printF();
			System.out.println();
			System.out.print("Printing backward: ");
			d.printB();


			System.out.println();

			
		}
	}

