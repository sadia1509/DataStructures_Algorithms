# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.

class Node:
    def __init__(self,v,n,p):
        self.value=v
        self.next=n
        self.prev=p


class DubLinCir:
    head=Node(None,None,None)

    def __init__(self, arr):
         tail=DubLinCir.head

         for i in arr:
             n=Node(i, None, None)

             tail.next=n
             n.prev=tail
             tail=tail.next


         tail.next=DubLinCir.head
         DubLinCir.head.prev=tail




    def printF(self):
        n=DubLinCir.head.next
        while n!=DubLinCir.head:
            print(n.value, end=" ")
            n=n.next


    def printB(self):
        n=DubLinCir.head.prev
        while n!=DubLinCir.head:
            print(n.value, end=" ")
            n=n.prev



d = DubLinCir([10, 20, 30, 40, 50])
d.printF()
print()
d.printB()

