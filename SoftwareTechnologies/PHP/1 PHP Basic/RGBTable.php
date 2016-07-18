<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>DrawButtons</title>
    <style>

    </style>
</head>
<body>
    <table>
        <thead>
            <tr>
                <th>Red</th>
                <th>Green</th>
                <th>Blue</th>
            </tr>
        </thead>
        <tbody>
            <?php
                $value = 51;
                for ($i = 1; $i <= 5; $i++){
                    $colorRed = "rgb($value, 0, 0)";
                    $colorGreen = "rgb(0, $value, 0)";
                    $colorBlue = "rgb(0, 0, $value)";
                    $tableRow = "<tr><td style='background-color:$colorRed'><br/></td>
                                     <td style='background-color:$colorGreen'><br/></td>
                                     <td style='background-color:$colorBlue'><br/></td></tr>";
                    $value+=51;
                    echo "$tableRow";
                }
            ?>
        </tbody>
    </table>
</body>
</html>