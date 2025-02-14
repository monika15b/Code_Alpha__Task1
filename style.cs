body {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
    font-family: Arial, sans-serif;
    background-color: #f0f0f0;
}

.gallery-container {
    text-align: center;
    background-color: #fff;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

.gallery img {
    width: 600px;
    height: 400px;
    object-fit: cover;
    border-radius: 10px;
}

.controls {
    margin-top: 20px;
}

.controls button {
    padding: 10px 20px;
    margin: 0 10px;
    border: none;
    border-radius: 5px;
    background-color: #007bff;
    color: white;
    cursor: pointer;
    font-size: 16px;
}

.controls button:hover {
    background-color: #0056b3;
}
