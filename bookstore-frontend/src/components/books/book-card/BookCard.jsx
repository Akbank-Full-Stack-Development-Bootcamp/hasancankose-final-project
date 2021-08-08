import { useHistory } from "react-router-dom";
import "./BookCard.css";

const BookCard = ({ imageUrl, title, author, id }) => {
  const history = useHistory();

  const handleClick = (path) => {
    history.push(`/${path}`);
  };
  return (
    <div className="card">
      <img
        className="card-image"
        src={imageUrl}
        alt=""
        style={{ width: "100%" }}
      />
      <div className="container">
        <h3>{title}</h3>
        <p>{author}</p>
      </div>
      <button className="btn-details" onClick={() => handleClick(id)}>
        Detaylar
      </button>
    </div>
  );
};

export default BookCard;
