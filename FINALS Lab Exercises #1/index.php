<!DOCTYPE html>
<html>
<head>
  <title>Lab 5: PHP + JSON + JavaScript (AJAX)</title>
</head>
<body>
  <h2>Lab 5: PHP + JSON + JavaScript (AJAX)</h2>

  <form id="loginForm">
    <label>Name:</label>
    <input type="text" id="name" value="Inna Amor"><br><br>
    <button type="submit">Submit</button>
  </form>

  <h3>Response:</h3>
  <pre id="response"></pre>

  <script>
    document.getElementById("loginForm").addEventListener("submit", function(e) {
      e.preventDefault(); // stop form from reloading

      const data = { name: document.getElementById("name").value };

      fetch("server.php", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(data)
      })
      .then(res => res.text()) // get raw JSON text
      .then(text => {
        document.getElementById("response").textContent = text;
      })
      .catch(error => {
        document.getElementById("response").textContent = "Error: " + error;
      });
    });
  </script>
</body>
</html>
