import math
def get_even_odd():
    e=[]
    o=[]
    num=int(input("Enter the number of values present in the list"))
    for i in range(num):
        n=int(input("Enter the value:")) 
        if(n%2==0):
            e.append(n)
            print("even")
        else:
            o.append(n)
            print("odd")
    print(f"The even elements in the list are{e}")
    print(f"The odd elements in the list are{o}")
    return o,e
def main():
    get_even_odd()
main()