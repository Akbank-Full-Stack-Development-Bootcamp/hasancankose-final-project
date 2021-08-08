import { useContext } from "react";
import BookListContext from "../../../context/booklist/bookListContext";
import BookList from "../../books/book-list/BookList";

const Home = () => {
  return (
    <div className="home-container">
      <BookList />
    </div>
  );
};

export default Home;
