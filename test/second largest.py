def get_second_largest():
    numbers=list(map(int, input("Enter the numbers:").split( )))
    numbers.sort(reverse=True)
    print(f"{numbers[1]}")
get_second_largest()