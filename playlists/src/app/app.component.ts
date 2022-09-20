import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Super Playlist App 3000';

  shoppingList:ShoppingItem [] = [
    {
      description: 'Beer',
      purchased: false
    }
  ];

  markPurchased(item:ShoppingItem) {
    item.purchased = true;
  }

  addItem(item: HTMLInputElement){
    const newItem: ShoppingItem = {
      description: item.value,
      purchased: false
    }
  }

  type ShoppingItem {
    description: string,
    purchased: boolean
  }

}
