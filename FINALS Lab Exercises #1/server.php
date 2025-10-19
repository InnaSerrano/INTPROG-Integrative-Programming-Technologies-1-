<?php
header('Content-Type: application/json');

// JSON input
$input = file_get_contents('php://input');
$data = json_decode($input, true);

// Extract name
$name = $data["name"] ?? "";

//JSON response
$response = [
  "status" => "success",
  "message" => "Welcome, " . $name . "!"
];

// JSON Output
echo json_encode($response);
;
