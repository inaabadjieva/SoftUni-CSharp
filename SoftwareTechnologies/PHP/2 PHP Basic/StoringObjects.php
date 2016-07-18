<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>StoringObject</title>
</head>
<body>
    <?php
        if(isset($_GET['delimiter']) && isset($_GET['input'])) {
            $delimiter = $_GET['delimiter'];
            $lines = $_GET['input'];

            $lines = explode("\n", $lines);
            $lines = array_map('trim', $lines);

            $student = new stdClass();

            for ($i = 0; $i < count($lines); $i++) {
                $props = explode($delimiter, $lines[$i]);
                $student->name = $props[0];
                $student->age = $props[1];
                $student->grade = floatval($props[2]);
                $list .= "<ul>";
                $list .= "<li>Name: $student->name</li>";
                $list .= "<li>Age: $student->age</li>";
                $list .= "<li>Grade: $student->grade</li>";
                $list .= "</ul>";
                echo $list;
                unset($list);
            }
        }
    ?>
    <form>
        Delimiter:<input type="text" name="delimiter">
        Input:<textarea name="input" rows="10"></textarea>
        <input type="submit" value="Submit">
    </form>
</body>
</html>