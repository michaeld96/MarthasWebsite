import { useEffect, useState } from "react";
import type { Product } from "./products";


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
      <ul>
        {products.map((item, index) => (
          <li key={index}>{item.name} - {item.price}</li>
        ))}
      </ul>
      <button onClick={addProduct}>Add Product</button>
    </div>
  )
}

export default App
