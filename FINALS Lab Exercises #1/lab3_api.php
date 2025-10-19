<?php
header('Content-Type: application/json');

$user = [
  "id" => 23151248,
  "name" => "Inna Amor Serrano",
  "email" => "serranoinnaamor_bsit@plmun.edu.ph",
  "status" => "active"
];

echo json_encode($user);
