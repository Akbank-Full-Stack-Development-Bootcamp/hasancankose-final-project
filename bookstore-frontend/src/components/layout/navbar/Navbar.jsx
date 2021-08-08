import PropTypes from "prop-types";
import { Link } from "react-router-dom";
import "./Navbar.css";

const Navbar = ({ title }) => {
  return (
    <div className="navbar bg-primary">
      <h2>{title}</h2>
    </div>
  );
};

Navbar.propTypes = {
  title: PropTypes.string,
};

Navbar.defaultProps = {
  title: "Bookstore",
};
export default Navbar;
