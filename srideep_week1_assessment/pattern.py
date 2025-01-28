def pattern(n):
    for i in range (n):
        print("*"*(n-i))
        
def main():
    n=int(input("Enter the n Value:"))
    pattern(n)
main()