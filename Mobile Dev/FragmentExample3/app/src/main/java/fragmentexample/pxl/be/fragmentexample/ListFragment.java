 // TODO 1. CREATE NEW ACTIVITY AND EXTEND FROM FRAGMENT

 package fragmentexample.pxl.be.fragmentexample;

import android.app.Fragment;
import android.app.FragmentTransaction;
import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

 public class ListFragment extends Fragment {

     ListView listView;

    @Override
     public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
         View view = inflater.inflate(R.layout.activity_list_fragment, container, false);

         return view;
     }

     @Override
     public void onActivityCreated(@Nullable Bundle savedInstanceState) {
         super.onActivityCreated(savedInstanceState);

         listView = (ListView) getView().findViewById(R.id.listView);


         listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
             @Override
             public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                 String item = (String)listView.getItemAtPosition(i);
                 Toast.makeText(getActivity(), item, Toast.LENGTH_SHORT).show();

                 DetailFragment detailFragment = (DetailFragment) getFragmentManager().findFragmentById(R.id.detail);
                 if (detailFragment != null && detailFragment.isVisible()) {
                     // Visible: send bundle
                     DetailFragment newFragment = new DetailFragment();
                     Bundle bundle=new Bundle();
                     bundle.putString("item", item);
                     newFragment.setArguments(bundle);

                     FragmentTransaction transaction = getFragmentManager().beginTransaction();
                     transaction.replace(detailFragment.getId(), newFragment);
                     transaction.addToBackStack(null);

                     // Commit the transaction
                     transaction.commit();
                 }
                 else {
                     // Not visible: start as intent
                     Intent intent = new Intent(getActivity().getBaseContext(), DetailActivity.class);
                     intent.putExtra("item", item);
                     getActivity().startActivity(intent);
                 }



             }
         });

     }
 }

