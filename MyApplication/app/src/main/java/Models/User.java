package Models;

public class User {
    private String log,pas,id;
    public User(){}

    public User(String log, String pas,String id) {
        this.log = log;
        this.pas = pas;
        this.id = id;
    }

    public String getLog() {
        return log;
    }

    public void setLog(String log) {
        this.log = log;
    }

    public String getPas() {
        return pas;
    }

    public void setPas(String pas) {
        this.pas = pas;
    }
}
