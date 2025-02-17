import { Component, ChangeDetectionStrategy, signal } from '@angular/core';
import { ResourceListItem } from '../types';

@Component({
  selector: 'app-resources-list',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: ` <div class="flex gap-4">
    @for (link of links(); track link.id) {
      <div class="card bg-neutral text-neutral-content w-96">
        <div class="card-body items-center text-center">
          <h2 class="card-title">Documentation: {{ link.title }}</h2>
          <p>{{ link.description }}</p>
          <div class="card-actions justify-end">
            <a class="btn btn-link" [href]="link.link" target="_blank">{{
              link.LinkText
            }}</a>
            <div>
              @for (tag of link.tags; track $index) {
                <div class="badge badge-secondary badge-outline">
                  {{ tag }}
                </div>
              }
            </div>
          </div>
        </div>
      </div>
    }
  </div>`,
  styles: ``,
})
export class ListComponent {
  links = signal<ResourceListItem[]>([
    {
      id: '1',
      title: 'Hypertheory Applied Angular Materials',
      description: 'Class Materials for Applied Angular',
      link: 'https://applied-angular.hypertheory.com',
      LinkText: 'Hypertheory.com',
      tags: ['Angular', 'TypeScript', 'Training'],
    },
  ]);
}
