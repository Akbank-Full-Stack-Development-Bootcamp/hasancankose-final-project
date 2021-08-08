import { useContext } from "react";
import BookListContext from "../../../context/booklist/bookListContext";
import BookCard from "../book-card/BookCard";
import "./BookList.css";

const BookList = () => {
  const { bookList } = useContext(BookListContext);

  return (
    <div className="book-list-container">
      {bookList.map(
        (book) => (
          console.log(book),
          (
            <BookCard
              key={book.id}
              imageUrl={book.imageUrl}
              title={book.title}
              author={book.authorName}
              id={book.id}
            />
          )
        )
      )}
    </div>
  );
};

export default BookList;
