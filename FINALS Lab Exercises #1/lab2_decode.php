<?php
$jsonString = '{"name":"Inna Amor Serrano","age":23,"email":"serranoinnaamor_bsit@plmun.edu.ph"}';

$obj = json_decode($jsonString);
$arr = json_decode($jsonString, true);

echo "Object: " . $obj->name . "<br>";
echo "Array: " . $arr["email"];
