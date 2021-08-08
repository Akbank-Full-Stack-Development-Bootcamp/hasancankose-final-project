import { useContext, useEffect, useState } from "react";
import { useParams, useHistory } from "react-router-dom";
import BookListContext from "../../../context/booklist/bookListContext";
import "./BookDetails.css";

const BookDetails = () => {
  const { bookList } = useContext(BookListContext);
  const { id } = useParams();
  const history = useHistory();

  const [book, setBook] = useState({});
  const [publishedDate, setPublishedDate] = useState("");

  useEffect(() => {
    const selectedBook = bookList.find((book) => book.id == id);
    setBook(selectedBook);
    console.log(selectedBook);
    setPublishedDate(selectedBook.publishedDate.substring(0, 4));
  }, []);

  const handleClick = () => {
    history.push("/");
  };

  return (
    <div className="book-details-container">
      <img className="details-image" src={book.imageUrl} alt="" />
      {/* <div className="empty"></div> */}
      <div className="details-info">
        <h2 className="item">{book.title}</h2>
        <p className="item">
          <strong>Yazar: </strong>
          {book.authorName}
        </p>
        <p className="item">
          <strong>Yayın Evi: </strong>
          {book.publisherName}
        </p>
        <p className="item">
          <strong>Dil: </strong>
          {book.languageName}
        </p>
        <p className="item">
          <strong>Açıklama: </strong>
          {book.plot}
        </p>
        <p className="item">
          <strong>İlk Baskı Yılı: </strong>
          {publishedDate}
        </p>
        <button className="btn-details" onClick={handleClick}>
          Geri Dön
        </button>
      </div>
    </div>
  );
};

export default BookDetails;
