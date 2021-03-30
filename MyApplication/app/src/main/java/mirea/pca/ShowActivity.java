package mirea.pca;

import android.content.Intent;
import android.os.Bundle;
import android.os.PersistableBundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.ArrayList;
import java.util.List;

import Models.User;

public class ShowActivity extends AppCompatActivity {
//    public ListView listView_2;
//    private ArrayAdapter<String> adapter_2;
//    private List<String> listData_2;
//    private DatabaseReference mDataBase;
//    private String GET_KEY = "Users";
//
//    @Override
//    public void onCreate(@Nullable Bundle savedInstanceState) {
//        super.onCreate(savedInstanceState);
//        setContentView(R.layout.show_layout);
//        init();
//        getDataForHistory();
//        getIntentMain();
//    }
//
//    private void init() {
//        listView_2 = findViewById(R.id.listView_2);
//        listData_2 = new ArrayList<>();
//        adapter_2 = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, listData_2);
//        listView_2.setAdapter(adapter_2);
//        mDataBase = FirebaseDatabase.getInstance().getReference(GET_KEY);
//    }
//
//    private void getDataForHistory() {
//        ValueEventListener vListener = new ValueEventListener() {
//            @Override
//            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
//                if (listData_2.size() > 0) listData_2.clear();
//                for (DataSnapshot ds : dataSnapshot.getChildren()) {
//                    User user = ds.getValue(User.class);
//                    assert user != null;
//                    listData_2.add(user.pass);
//                }
//                adapter_2.notifyDataSetChanged();
//            }
//
//            @Override
//            public void onCancelled(@NonNull DatabaseError databaseError) {
//            }
//        };
//        mDataBase.addValueEventListener(vListener);
//    }
//
//    private void getIntentMain() {
//        Intent i = getIntent();
//    }
}
