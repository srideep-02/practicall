class library:
    def __init__(self,title,author,isbn):
        self.title= title
        self.author=author
        self.isbn=isbn
        
    def display(self):
        print(f"The  title of book is:{self.title}\n The author is:{self.author}\nThe isbn number is:{self.isbn}")
obj = library("bob","boss",123)
obj.display()