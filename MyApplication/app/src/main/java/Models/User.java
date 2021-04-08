package Models;

import java.util.List;

public class User {
    public String login,pass,id;
    public String Desktops;

public User(){}

    public User(String login, String pass, String id,String Desktops) {
        this.login = login;
        this.pass = pass;
        this.id = id;
        this.Desktops=Desktops;
    }
}