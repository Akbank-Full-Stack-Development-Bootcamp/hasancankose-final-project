import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import "./App.css";
import BookDetails from "./components/books/book-details/BookDetails";
import Navbar from "./components/layout/navbar/Navbar";
import Home from "./components/pages/home/Home";
import BookListState from "./context/booklist/bookListState";

function App() {
  return (
    <BookListState>
      <Router>
        <Navbar />
        <div className="container">
          <Switch>
            <Route exact path="/" component={Home} />
            <Route exact path="/:id" component={BookDetails} />
          </Switch>
        </div>
      </Router>
    </BookListState>
  );
}

export default App;
