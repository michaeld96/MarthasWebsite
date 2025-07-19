import { useEffect, useState } from "react";
import type { Product } from "../models/products";
import Catalog from "../../features/catalog/Catalog";


function App() {

  const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    fetch('https://localhost:5001/api/products')
      .then(response => response.json())
      .then(data => setProducts(data));
  }, []);

  const addProduct = () => {
    setProducts(prevState => 
      [...prevState, 
        {
          id: prevState.length + 1,
          name: 'product' + (prevState.length + 1),
          description: 'test',
          price: (prevState.length + 1) * 100,
          pictureUrl: 'testURL',
          type: 'testType'
        }
      ]);
  }

  return (
    <div>
      <h1>Martha's Website</h1>
      <Catalog products={products} addProduct={addProduct}/>
    </div>
  )
}

export default App
