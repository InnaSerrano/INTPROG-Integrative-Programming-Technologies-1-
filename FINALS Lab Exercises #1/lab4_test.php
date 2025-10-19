<!DOCTYPE html>
<html>
<head>
  <title>Lab 4 JSON Test</title>
</head>
<body>
  <h2>Send JSON to PHP (Lab 4)</h2>

  <label>Username:</label>
  <input type="text" id="username" value="admin"><br><br>

  <label>Password:</label>
  <input type="text" id="password" value="1234"><br><br>

  <button id="sendBtn">Send JSON</button>

  <h3>Response:</h3>
  <pre id="response"></pre>

  <script>
    document.getElementById("sendBtn").addEventListener("click", function() {
      const data = {
        username: document.getElementById("username").value,
        password: document.getElementById("password").value
      };

      fetch("lab4_input.php", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(data)
      })
      .then(res => res.text())
      .then(text => {
        document.getElementById("response").textContent = text;
      });
    });
  </script>
</body>
</html>
