import Product from "./components/Product";
import Cart from "./components/Cart";
import { Home } from "./components/Home";
import FetchApi from "./components/FetchApi";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/product',
    element: <Product />
  },
  {
    path: '/cart',
    element: <Cart />
  },
  {
    path: '/fetch',
    element: <FetchApi />
  }
];

export default AppRoutes;
