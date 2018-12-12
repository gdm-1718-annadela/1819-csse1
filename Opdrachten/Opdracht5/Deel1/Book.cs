namespace Deel1{
  public class Book{
    private string name;
    private Author author;
    private double price;
    private int qtyInStock;

    public Author author
    {
      get;
      set;
    }

    public Book(string name, Author author, double price, int qtyInStock){
      this.name = name;
      this.author = author;
      this.price = price;
      this.qtyInStock = qtyInStock;
    }

    string getName(){
      return this.name;
    }

    Author getAuthor(){
      return this.author;
    }

    double getPrice(){
      return this.price;
    }

    public void setPrice(){
      this.price = 20;
    }

    int getQtyInStock(){
      return this.qtyInStock;
    }

    public void setQtyInStock(){
      this.qtyInStock = 8;
    }

    public void print(){
    }

    string getAuthorName(){
      
    }

  }
}