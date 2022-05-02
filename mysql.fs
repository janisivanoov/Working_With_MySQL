open MySql.Data.MySqlClient

let showAll = 
    let cs = @"server=localhost;userid=user;password=1224;database=db";

    use con = new MySqlConnection(cs)
    con.Open()

    let sql = "SELECT * FROM clmn"

    use cmd = new MySqlCommand(sql, con)

    use rdr = cmd.ExecuteReader()

    while rdr.Read() do{
        printfn "%d %s %d" (rdr.GetInt32 0) (rdr.GetString 1) (rdr.GetInt32 2)
    }

showAll