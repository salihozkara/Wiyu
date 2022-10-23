import { Component, OnInit } from '@angular/core';
import { BlockchainService } from '../services/blockchain.service';

@Component({
  selector: 'lib-blockchain',
  template: ` <p>blockchain works!</p> `,
  styles: [],
})
export class BlockchainComponent implements OnInit {
  constructor(private service: BlockchainService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
