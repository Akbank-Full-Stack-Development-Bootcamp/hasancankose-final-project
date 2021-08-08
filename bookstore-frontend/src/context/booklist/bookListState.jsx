import { useState, useEffect } from "react";
import bookListContext from "./bookListContext";

const BookListState = (props) => {
  const [bookList, setBookList] = useState([]);
  const [authorList, setAuthorList] = useState([]);
  const [languageList, setLanguageList] = useState([]);
  const [publisherList, setPublisherList] = useState([]);

  useEffect(() => {
    getAuthors();
    getLanguages();
    getPublishers();
  }, []);

  useEffect(() => {
    if (authorList.length && languageList.length && publisherList.length)
      getBooks();
  }, [authorList, languageList, publisherList]);

  const getName = (list, id) => {
    return list.find((item) => item.id === id).name;
  };

  const mapBookList = (bookListResponse) => {
    bookListResponse.forEach((book) => {
      book.authorName = getName(authorList, book.authorId);
      book.languageName = getName(languageList, book.languageId);
      book.publisherName = getName(publisherList, book.publisherId);
    });
    setBookList(bookListResponse);
  };

  const getData = async (_url, setState) => {
    const response = await fetch(_url);
    const json = await response.json();
    setState(json);
  };

  const getAuthors = () => {
    const authorListUrl = "https://localhost:44337/api/Authors";
    getData(authorListUrl, setAuthorList);
  };

  const getLanguages = () => {
    const languageListUrl = "https://localhost:44337/api/Languages";
    getData(languageListUrl, setLanguageList);
  };

  const getPublishers = () => {
    const publisherListUrl = "https://localhost:44337/api/Publishers";
    getData(publisherListUrl, setPublisherList);
  };

  const getBooks = () => {
    const bookListUrl = "https://localhost:44337/api/Books";
    getData(bookListUrl, mapBookList);
  };

  return (
    <bookListContext.Provider value={{ bookList }}>
      {props.children}
    </bookListContext.Provider>
  );
};

export default BookListState;
