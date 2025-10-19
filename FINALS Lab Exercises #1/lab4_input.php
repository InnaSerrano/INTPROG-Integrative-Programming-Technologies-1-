<?php
// raw JSON data 
$json = file_get_contents('php://input');

// Decode the JSON into a PHP 
$data = json_decode($json, true);

// Check if both username and password are present
if (isset($data["username"]) && isset($data["password"])) {
    echo "Username: " . $data["username"] . "\n";
    echo "Password: " . $data["password"];
} else {
    echo "No JSON data received.";
}
