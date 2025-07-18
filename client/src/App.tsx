const products = [
  {name: 'product1', price: 100.00},
  {name: 'product2', price: 100.00},
  {name: 'product3', price: 100.00},
  {name: 'product4', price: 100.00},
  {name: 'product5', price: 100.00},
];

function App() {

  return (
    <div>
      <h1>Martha's Website</h1>
      <ul>
        {products.map((item, index) => (
          <li key={index}>{item.name} - {item.price}</li>
        ))}
      </ul>
    </div>
  )
}

export default App
